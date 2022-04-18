import { Component, EventEmitter, Input,  Output } from '@angular/core';
import { take } from 'rxjs/operators';

import { ImageTile, ImageTileLabel } from '@app/core';
import { ImageTileWindowsService } from './image-tile-windows.service';

@Component({
    selector: 'app-image-tile',
    templateUrl: './image-tile.component.html',
    styleUrls: ['./image-tile.component.scss']
})
export class ImageTileComponent
{
    /**
     * Image tile labels with fillers.
     *
     * @returns {ImageTileText[]}
     */
    public get tileLabels(): ImageTileLabel[]
    {
        let labels = [];

        for (let position = 1; position < 25; position++)
        {
            let existedText = this.imageTile.labels.find(t => t.position == position);

            labels.push(existedText instanceof ImageTileLabel ? existedText : new ImageTileLabel({ position: position}));
        }

        return labels;
    }

    /**
     * Editable image tile.
     *
     * @type {ImageTile}
     */
    @Input() public imageTile: ImageTile;

    /**
     * "Remove" event emitter.
     *
     * @type {EventEmitter<ImageTile>}
     */
    @Output() public remove: EventEmitter<ImageTile> = new EventEmitter<ImageTile>();

    /**
     * "Update" event emitter.
     *
     * @type {EventEmitter<ImageTile>}
     */
    @Output() public update: EventEmitter<ImageTile> = new EventEmitter<ImageTile>();

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
     * @param {ImageTile} imageTile
     *
     * @returns {void}
     */
    public openEditTileFormWindow(imageTile: ImageTile): void
    {
        this.imageTileWindowsService
            .openTileFormWindow(imageTile)
            .pipe(take(1))
            .subscribe(imageTile => {
                if (imageTile) {
                    this.update.emit(imageTile);
                }
            });
    }

    /**
     * Opens the delete confirmation window and triggers the delete event.
     *
     * @param {ImageTile} imageTile
     *
     * @returns {void}
     */
    public removeTile(imageTile: ImageTile): void
    {
        this.imageTileWindowsService
            .openTileRemoveConfirmationWindow(imageTile)
            .pipe(take(1))
            .subscribe(isConfirmed => {
                if (isConfirmed) {
                    this.remove.emit(imageTile);
                }
            });
    }
}
