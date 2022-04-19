import { OnInit, Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { filter, take, tap } from 'rxjs/operators';

import { RepositoriesFabrica, SpinnerService, ImageTile } from '@app/core';
import { ImageTileWindowsService } from '../image-tile';
import { ImageTileState } from './image-tile-state';

@Component({
    selector: 'app-image-tiles-dashboard',
    templateUrl: './image-tiles-dashboard.component.html',
    styleUrls: ['./image-tiles-dashboard.component.scss']
})
export class ImageTilesDashboardComponent implements OnInit
{
    /**
     * Image tiles states.
     *
     * @type {ImageTileState[]}
     */
    public imageTileStates: ImageTileState[] = [];

    /**
     * Constructor.
     *
     * @param {ActivatedRoute} activatedRoute
     * @param {RepositoriesFabrica} repositoriesFabrica
     * @param {SpinnerService} spinnerService
     * @param {ImageTileWindowsService} imageTileWindowsService
     */
    public constructor(
        private activatedRoute: ActivatedRoute,
        private repositoriesFabrica: RepositoriesFabrica,
        private spinnerService: SpinnerService,
        private imageTileWindowsService: ImageTileWindowsService
    )
    {
        return;
    }

    /**
     * {@inheritdoc}
     */
    public ngOnInit(): void
    {
        this.activatedRoute.data
            .pipe(
                take(1),
                tap(() => this.spinnerService.hide())
            )
            .subscribe(routeData => {
                this.imageTileStates = routeData.requestData.map((t: ImageTile) => new ImageTileState(t));
            });
    }

    /**
     * Opens the tile add window and triggers the update event.
     *
     * @returns {void}
     */
    public openAddTileFormWindow(): void
    {
        this.imageTileWindowsService
            .openImageTileFormWindow(null)
            .pipe(
                take(1),
                filter(i => i instanceof ImageTile)
            )
            .subscribe(imageTile => this.imageTileStates.push(new ImageTileState(imageTile).markAsNew()));
    }

    /**
     * Saves tile changes.
     *
     * @returns {void}
     */
    public saveTilesChanges(): void
    {
        this.imageTileStates.forEach(t => {
            if (t.isСhanged || t.isNew) {
                this.repositoriesFabrica
                    .getImageTileRepository()
                    .save(t.tile)
                    .pipe(take(1))
                    .subscribe(() => {});
            }

            if (t.toDelete) {
                this.repositoriesFabrica
                    .getImageTileRepository()
                    .delete(t.tile)
                    .pipe(take(1))
                    .subscribe(() => {});
            }
        });
    }

    /**
     * Reverts tile changes.
     *
     * @returns {void}
     */
    public cancelTilesChanges(): void
    {
        this.spinnerService.show();
        this.repositoriesFabrica.getImageTileRepository().find()
            .pipe(
                take(1),
                tap(() => this.spinnerService.hide())
            )
            .subscribe(imageTiles => this.imageTileStates = imageTiles.map(t => new ImageTileState(t)));
    }

    /**
     * Image tile removal event handler.
     *
     * @param {ImageTiles} imageTile
     *
     * @returns {void}
     */
    public removeTileHandler(imageTile: ImageTile): void
    {
        this.imageTileStates = this.imageTileStates.map(t => imageTile == t.tile ? t.markToDelete() : t);
    }

    /**
     * Image tile refresh event handler.
     *
     * @param {ImageTiles} oldImageTile
     * @param {ImageTiles} updatedImageTile
     *
     * @returns {void}
     */
    public updateTileHandler(oldImageTile: ImageTile, updatedImageTile: ImageTile): void
    {
        this.imageTileStates = this.imageTileStates.map (t => {
            if (t.tile === oldImageTile) {
                t.tile = updatedImageTile;
                t.markAsСhanged();
            }

            return t;
        });
    }
}
