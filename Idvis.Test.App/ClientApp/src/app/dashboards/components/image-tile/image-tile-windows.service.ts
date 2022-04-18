import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';

import { ImageTile, ImageTileText } from '@app/core';
import { ConfirmDialogComponent } from '@app/shared';
import { ImageTileFormDialogComponent } from '../image-tile-form-dialog';
import { ImageTileTextFormDialogComponent } from '../image-tile-text-form-dialog';

@Injectable()
export class ImageTileWindowsService
{
    /**
     * Constructor.
     *
     * @param {MatDialog} dialogService
     */
    public constructor(private dialogService: MatDialog)
    {
        return;
    }

    /**
     * Opens a modal window for editing/creating a image tile.
     *
     * @param {Tile | null} imageTile
     *
     * @returns {Observable<Tile>}
     */
    public openImageTileFormWindow(imageTile: ImageTile | null): Observable<ImageTile>
    {
        return this.dialogService.open(
            ImageTileFormDialogComponent,
            {
                panelClass: 'app-custom-dialog',
                width: '550px',
                data: { imageTile: imageTile }
            }
        )
            .afterClosed();
    }

    /**
     * Opens a modal window to confirm the deletion of the image tile.
     *
     * @param {ImageTile} imageTile
     *
     * @returns {Observable<Tile>}
     */
    public openImageTileRemoveConfirmationWindow(imageTile: ImageTile): Observable<ImageTile>
    {
        return this.dialogService.open(
            ConfirmDialogComponent,
            { data: { confirmText: 'Are you sure you want to delete the "' + imageTile.title +'" tile?' } }
        )
            .afterClosed();
    }

    /**
     * Opens a modal window to edit image tile text.
     *
     * @param {ImageTileText} imageTileText
     *
     * @returns {Observable<ImageTileText>}
     */
    public openImageTileTextEditWindow(imageTileText: ImageTileText): Observable<ImageTileText>
    {
        return this.dialogService.open(
            ImageTileTextFormDialogComponent,
            {
                panelClass: 'app-custom-dialog',
                width: '550px',
                data: { imageTileText: imageTileText }
            }
        )
            .afterClosed();
    }
}
