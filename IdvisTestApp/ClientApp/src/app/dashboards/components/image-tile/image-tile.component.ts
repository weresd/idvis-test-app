import { CdkDrag, CdkDragDrop, CdkDragEnter, CdkDropList } from '@angular/cdk/drag-drop';
import { Component, EventEmitter, Input,  OnInit,  Output } from '@angular/core';
import { take } from 'rxjs/operators';

import { ImageTile, ImageTileText } from '@app/core';
import { ImageTileWindowsService } from './image-tile-windows.service';
import * as _ from 'lodash';

@Component({
    selector: 'app-image-tile',
    templateUrl: './image-tile.component.html',
    styleUrls: ['./image-tile.component.scss']
})
export class ImageTileComponent implements OnInit
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

    ngOnInit(): void {
        let texts = [];

        for (let position = 1; position < 25; position++)
        {
            let existedText = this.imageTile.texts.find(t => t.position == position);

            texts.push(existedText instanceof ImageTileText ? existedText : new ImageTileText({ position: position}));
        }

        this.imageTile.texts = texts;
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

        this.imageTile.texts = this.imageTile.texts.map(t => {
            if (this.selectedImageTileText.position == t.position) {
                t.value = null;
                t.unit = null;
            }

            return t;
        });
        this.selectedImageTileText = null;

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
                    this.imageTile.texts.map(t => {
                        if (t.position == eventImageTileText.position) {
                            t = eventImageTileText;
                        }

                        return t;
                    });
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

    drop1(event: CdkDragEnter<string[], ImageTileText>, replaceableImageTileText: ImageTileText)
    {
        console.log(event);
        console.log(replaceableImageTileText);


        if (event.container === event.item.dropContainer)
        {
            return;
        }

        /*const currentText = event.item.data;
        const currentTextPosition = currentText.position;

        currentText.position = replaceableImageTileText.position;
        replaceableImageTileText.position = currentTextPosition;

        this.imageTile.texts = this.imageTile.texts.sort((a, b) => a.position - b.position);*/

        let containerFrom = event.container.element.nativeElement;console.log(containerFrom);
        let containerTo   = event.item.dropContainer.element.nativeElement;console.log(containerTo);

        let containerFromDragElement = containerFrom.querySelector('.app-image-tile__grid-item');console.log(containerFromDragElement);
        let containerToDragElement = containerTo.querySelector('.app-image-tile__grid-item');console.log(containerToDragElement);

        containerFrom.removeChild(containerFromDragElement);
        containerTo.removeChild(containerToDragElement);

        containerFrom.append(containerToDragElement);
        containerTo.append(containerFromDragElement);
    }

    drop(event: CdkDragDrop<string[]>, replaceableImageTileText: ImageTileText)
    {
        if (event.container === event.previousContainer)
        {
            return;
        }

        const currentText = event.item.data as ImageTileText;
        const currentTextPosition = currentText.position;

        currentText.position = replaceableImageTileText.position;
        replaceableImageTileText.position = currentTextPosition;

        this.imageTile.texts = this.imageTile.texts.sort((a, b) => a.position - b.position);

        this.update.emit(this.imageTile);
    }

    cdkDropListEnterPredicate(drag: CdkDrag, drop: CdkDropList)
    {
        /*console.log(drag);
        //console.log(drop);

        let containerFrom = drag.dropContainer.element.nativeElement;
        let containerTo   = drop.element.nativeElement;

        let containerFromDragElement = containerFrom.firstChild;
        let containerToDragElement = containerTo.firstChild;

        containerFrom.removeChild(containerFromDragElement);
        containerTo.removeChild(containerToDragElement);

        containerFrom.append(containerToDragElement);
        containerTo.append(containerFromDragElement);*/

        return true;
    }
}
