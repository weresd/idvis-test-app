import { Component, Inject, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

import { Tile } from '@app/core';

@Component({
    selector: 'app-tile-form-dialog',
    templateUrl: './tile-form-dialog.component.html',
    styleUrls: ['./tile-form-dialog.component.scss']
})
export class TileFormDialogComponent implements OnInit
{
    /**
     * Editable tile.
     *
     * @type {Tile}
     */
    public tile: Tile;

    /**
     * Form group.
     *
     * @type {FormGroup}
     */
    public formGroup: FormGroup;

    /**
     * Constructor.
     *
     * @param {MatDialogRef<UserFormDialogComponent>} dialogRef
     * @param {any} data
     */
    public constructor(
        public dialogRef: MatDialogRef<TileFormDialogComponent>,
        @Inject(MAT_DIALOG_DATA) data: any
    )
    {
        this.tile = data.tile === null ? new Tile() : data.tile;
    }

    /**
     * {@inheritdoc}
     */
    public ngOnInit(): void
    {
        this.resetForm();
    }

    /**
     * Resets the form of the tile.
     *
     * @returns {void}
     */
    private resetForm(): void
    {
        this.formGroup = new FormGroup({
            title: new FormControl(this.tile.title, [Validators.required, Validators.minLength(4)]),
            img: new FormControl(this.tile.img, [Validators.required, Validators.minLength(4)]),
        });
    }

    /**
     * Saves the tile data from the form.
     *
     * @returns {void}
     */
    public save(): void
    {
        if (this.formGroup.invalid)
        {
            return;
        }

        this.tile.title = this.formGroup.get('title').value;
        this.tile.img = this.formGroup.get('img').value;

        this.dialogRef.close(this.tile);
    }

    /**
     * Clears a form field.
     *
     * @param {AbstractControl} formcontrol
     *
     * @returns {void}
     */
    public clearField(formcontrol: AbstractControl): void
    {
        formcontrol.setValue('');
        formcontrol.markAsUntouched();
    }
}
