import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';

import { ImageTile } from '@app/core';
import { ConfirmDialogComponent } from '@app/shared';
import { ImageTileFormDialogComponent } from '../image-tile-form-dialog';

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
     * Opens a modal window for editing/creating a tile.
     *
     * @param {Tile | null} imageTile
     *
     * @returns {Observable<Tile>}
     */
    public openTileFormWindow(imageTile: ImageTile | null): Observable<ImageTile>
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
     * Opens a modal window to confirm the deletion of the tile.
     *
     * @param {ImageTile} imageTile
     *
     * @returns {Observable<Tile>}
     */
    public openTileRemoveConfirmationWindow(imageTile: ImageTile): Observable<ImageTile>
    {
        return this.dialogService.open(
            ConfirmDialogComponent,
            { data: { confirmText: 'Are you sure you want to delete the "' + imageTile.title +'" tile?' } }
        )
            .afterClosed();
    }
}
