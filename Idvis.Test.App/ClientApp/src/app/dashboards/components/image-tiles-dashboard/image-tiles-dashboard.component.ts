import { OnInit, Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { take, tap } from 'rxjs/operators';

import { RepositoriesFabrica, SpinnerService, Tile } from '@app/core';
import { ImageTileWindowsService } from '../image-tile';

@Component({
    selector: 'app-image-tiles-dashboard',
    templateUrl: './image-tiles-dashboard.component.html',
    styleUrls: ['./image-tiles-dashboard.component.scss']
})
export class ImageTilesDashboardComponent implements OnInit
{
    /**
     * Tiles.
     *
     * @type {Tile[]}
     */
    public tiles: Tile[] = [];

    /**
     * Removed tiles.
     *
     * @type {Tile[]}
     */
    public removedTiles: Tile[] = [];

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
                this.tiles = routeData.requestData;
            });
    }

    /**
     * Opens the tile add window and triggers the update event.
     *
     * @param {Tile} tile
     *
     * @returns {void}
     */
    public openAddTileFormWindow(): void
    {
        this.imageTileWindowsService
            .openTileFormWindow(null)
            .pipe(take(1))
            .subscribe(tile => this.tiles.push(tile));
    }

    /**
     * Saves tile changes.
     *
     * @returns {void}
     */
    public saveTilesChanges(): void
    {
        this.tiles.map(t => this.repositoriesFabrica
            .getTileRepository()
            .save(t)
            .subscribe(() => {})
        );

        this.removedTiles.map(t => this.repositoriesFabrica
            .getTileRepository()
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
        this.repositoriesFabrica.getTileRepository().find()
            .pipe(
                take(1),
                tap(() => this.spinnerService.hide())
            )
            .subscribe(tiles => {
                this.tiles = tiles;
                this.removedTiles = [];
            });
    }

    /**
     * Image tile removal event handler.
     *
     * @param {Tile} tile
     *
     * @returns {void}
     */
    public removeTileHandler(tile: Tile): void
    {
        this.removedTiles.push(tile);
        this.tiles = this.tiles.filter(t => t !== tile);
    }

    /**
     * Image tile refresh event handler.
     *
     * @param {Tile} oldTile
     * @param {Tile} updatedtile
     *
     * @returns {void}
     */
    public updateTileHandler(oldTile: Tile, updatedtile: Tile): void
    {
        this.tiles = this.tiles.map (t => t === oldTile ? updatedtile : t);
    }
}
