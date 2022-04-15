import { OnInit, Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { take, tap } from 'rxjs/operators';

import { RepositoriesFabrica, SpinnerService, ImageTile } from '@app/core';
import { ImageTileWindowsService } from '../image-tile';

@Component({
    selector: 'app-image-tiles-dashboard',
    templateUrl: './image-tiles-dashboard.component.html',
    styleUrls: ['./image-tiles-dashboard.component.scss']
})
export class ImageTilesDashboardComponent implements OnInit
{
    /**
     * Image tiles.
     *
     * @type {ImageTile[]}
     */
    public imageTiles: ImageTile[] = [];

    /**
     * Removed image tiles.
     *
     * @type {ImageTile[]}
     */
    public removedImageTiles: ImageTile[] = [];

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
                this.imageTiles = routeData.requestData;
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
            .openTileFormWindow(null)
            .pipe(take(1))
            .subscribe(imageTile => this.imageTiles.push(imageTile));
    }

    /**
     * Saves tile changes.
     *
     * @returns {void}
     */
    public saveTilesChanges(): void
    {
        this.imageTiles.map(t => this.repositoriesFabrica
            .getImageTileRepository()
            .save(t)
            .subscribe(() => {})
        );

        this.removedImageTiles.map(t => this.repositoriesFabrica
            .getImageTileRepository()
            .delete(t)
            .subscribe(() => {})
        );
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
            .subscribe(imageTiles => {
                this.imageTiles = imageTiles;
                this.removedImageTiles = [];
            });
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
        this.removedImageTiles.push(imageTile);
        this.imageTiles = this.imageTiles.filter(t => t !== imageTile);
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
        this.imageTiles = this.imageTiles.map (t => t === oldImageTile ? updatedImageTile : t);
    }
}
