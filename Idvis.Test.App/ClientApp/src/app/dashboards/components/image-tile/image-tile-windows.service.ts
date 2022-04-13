import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';

import { Tile } from '@app/core';
import { ConfirmDialogComponent } from '@app/shared';
import { TileFormDialogComponent } from '../tile-form-dialog';

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
     * @param {Tile | null} tile
     *
     * @returns {Observable<Tile>}
     */
    public openTileFormWindow(tile: Tile | null): Observable<Tile>
    {
        return this.dialogService.open(
            TileFormDialogComponent,
            {
                panelClass: 'app-custom-dialog',
                width: '550px',
                data: { tile: tile }
            }
        )
            .afterClosed();
    }

    /**
     * Opens a modal window to confirm the deletion of the tile.
     *
     * @param {Tile} tile
     *
     * @returns {Observable<Tile>}
     */
    public openTileRemoveConfirmationWindow(tile: Tile): Observable<Tile>
    {
        return this.dialogService.open(
            ConfirmDialogComponent,
            { data: { confirmText: 'Are you sure you want to delete the "' + tile.title +'" tile?' } }
        )
            .afterClosed();
    }
}
