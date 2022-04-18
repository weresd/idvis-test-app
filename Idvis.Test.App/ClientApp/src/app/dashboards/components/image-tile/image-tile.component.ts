import { Component, EventEmitter, Input,  Output } from '@angular/core';
import { take } from 'rxjs/operators';

import { ImageTile, ImageTileText } from '@app/core';
import { ImageTileWindowsService } from './image-tile-windows.service';

@Component({
    selector: 'app-image-tile',
    templateUrl: './image-tile.component.html',
    styleUrls: ['./image-tile.component.scss']
})
export class ImageTileComponent
{
    /**
     * Selected image tile text.
     *
     * @type {ImageTileText}
     */
    public selectedImageTileText: ImageTileText = null;

    /**
     * Image tile texts with fillers.
     *
     * @returns {ImageTileText[]}
     */
    public get tileTexts(): ImageTileText[]
    {
        let texts = [];

        for (let position = 1; position < 25; position++)
        {
            let existedText = this.imageTile.texts.find(t => t.position == position);

            texts.push(existedText instanceof ImageTileText ? existedText : new ImageTileText({ position: position}));
        }

        return texts;
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
    public openEditImageTileFormWindow(imageTile: ImageTile): void
    {
        this.imageTileWindowsService
            .openImageTileFormWindow(imageTile)
            .pipe(take(1))
            .subscribe(imageTile => {
                if (imageTile)
                {
                    this.update.emit(imageTile);
                }
            });
    }

    /**
     * Opens the delete confirmation window and triggers the delete image tile event.
     *
     * @param {ImageTile} imageTile
     *
     * @returns {void}
     */
    public removeImageTile(imageTile: ImageTile): void
    {
        this.imageTileWindowsService
            .openImageTileRemoveConfirmationWindow(imageTile)
            .pipe(take(1))
            .subscribe(isConfirmed => {
                if (isConfirmed)
                {
                    this.remove.emit(imageTile);
                }
            });
    }

    /**
     * Removes the selected image tile text.
     *
     * @returns {void}
     */
    public removeSelectedImageTileText(): void
    {
        if (this.selectedImageTileText === null)
        {
            return;
        }

        this.imageTile.texts = this.imageTile.texts.filter(t => t !== this.selectedImageTileText);
        this.update.emit(this.imageTile);
    }

    /**
     * Opens the tile editing window and triggers the update event.
     *
     * @returns {void}
     */
    public openEditImageTileTextFormWindow(): void
    {
        const imageTileText = this.tileTexts.find(l => l.isEmpty);

        if (!imageTileText)
        {
            return;
        }

        this.imageTileWindowsService
            .openImageTileTextEditWindow(imageTileText)
            .pipe(take(1))
            .subscribe(eventImageTileText => {
                if (eventImageTileText)
                {
                    this.imageTile.texts.push(eventImageTileText);
                    this.update.emit(this.imageTile);
                }
            });
    }

    /**
     * Image tile text selection handler.
     *
     * @param {ImageTileText} imageTileText
     *
     * @returns {void}
     */
    public selectImageTileTextHandler(imageTileText: ImageTileText): void
    {
        if (this.selectedImageTileText === imageTileText || imageTileText.isEmpty)
        {
            this.selectedImageTileText = null;
        }
        else
        {
            this.selectedImageTileText = imageTileText;
        }
    }
}
