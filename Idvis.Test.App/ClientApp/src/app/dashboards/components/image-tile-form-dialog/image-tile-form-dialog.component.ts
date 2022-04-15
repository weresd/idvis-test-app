import { Component, Inject, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

import { ImageTile } from '@app/core';

@Component({
    selector: 'app-image-tile-form-dialog',
    templateUrl: './image-tile-form-dialog.component.html',
    styleUrls: ['./image-tile-form-dialog.component.scss']
})
export class ImageTileFormDialogComponent implements OnInit
{
    /**
     * Editable image tile.
     *
     * @type {ImageTile}
     */
    public imageTile: ImageTile;

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
        public dialogRef: MatDialogRef<ImageTileFormDialogComponent>,
        @Inject(MAT_DIALOG_DATA) data: any
    )
    {
        this.imageTile = data.imageTile === null ? new ImageTile() : data.imageTile;
    }

    /**
     * {@inheritdoc}
     */
    public ngOnInit(): void
    {
        this.resetForm();
    }

    /**
     * Resets the form of the image tile.
     *
     * @returns {void}
     */
    private resetForm(): void
    {
        this.formGroup = new FormGroup({
            title: new FormControl(this.imageTile.title, [Validators.required, Validators.minLength(4)]),
            img: new FormControl(this.imageTile.img, [Validators.required, Validators.minLength(4)]),
        });
    }

    /**
     * Saves the image tile data from the form.
     *
     * @returns {void}
     */
    public save(): void
    {
        if (this.formGroup.invalid)
        {
            return;
        }

        this.imageTile.title = this.formGroup.get('title').value;
        this.imageTile.img = this.formGroup.get('img').value;

        this.dialogRef.close(this.imageTile);
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
