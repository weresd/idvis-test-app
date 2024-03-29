import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
    selector: 'app-confirm-dialog',
    templateUrl: './confirm-dialog.component.html',
    styleUrls: ['./confirm-dialog.component.scss']
})
export class ConfirmDialogComponent
{
    /**
     * Dialog text.
     *
     * @type {string}
     */
    public confirmText: string = '';

    /**
     * Constructor.
     *
     * @param {MatDialogRef<ConfirmDialogComponent>} dialogRef
     * @param {any} data
     */
    public constructor(
        public dialogRef: MatDialogRef<ConfirmDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any
    )
    {
        this.confirmText = data.confirmText;
    }
}
