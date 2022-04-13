import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { take } from 'rxjs/operators';

import { Tile } from '@app/core';
import { ImageTileWindowsService } from './image-tile-windows.service';

@Component({
    selector: 'app-image-tile',
    templateUrl: './image-tile.component.html',
    styleUrls: ['./image-tile.component.scss']
})
export class ImageTileComponent
{
    /**
     * Editable tile.
     *
     * @type {Tile}
     */
    @Input() public tile: Tile;

    /**
     * "Remove" event emitter.
     *
     * @type {EventEmitter<Tile>}
     */
    @Output() public remove: EventEmitter<Tile> = new EventEmitter<Tile>();

    /**
     * "Update" event emitter.
     *
     * @type {EventEmitter<Tile>}
     */
    @Output() public update: EventEmitter<Tile> = new EventEmitter<Tile>();

    /**
     * Constructor.
     *
     * @param {ImageTileService} imageTileService
     */
    public constructor(public imageTileWindowsService: ImageTileWindowsService)
    {
        return;
    }

    /**
     * Opens the tile editing window and triggers the update event.
     *
     * @param {Tile} tile
     *
     * @returns {void}
     */
    public openEditTileFormWindow(tile: Tile): void
    {
        this.imageTileWindowsService
            .openTileFormWindow(tile)
            .pipe(take(1))
            .subscribe(tile => this.update.emit(tile));
    }

    /**
     * Opens the delete confirmation window and triggers the delete event.
     *
     * @param {Tile} tile
     *
     * @returns {void}
     */
    public removeTile(tile: Tile): void
    {
        this.imageTileWindowsService
            .openTileRemoveConfirmationWindow(tile)
            .pipe(take(1))
            .subscribe(answer => answer ? this.remove.emit(tile) : null);
    }
}
