import { Component, Inject, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

import { ImageTileText } from '@app/core';

@Component({
    selector: 'app-image-tile-text-form-dialog',
    templateUrl: './image-tile-text-form-dialog.component.html',
    styleUrls: ['./image-tile-text-form-dialog.component.scss']
})
export class ImageTileTextFormDialogComponent implements OnInit
{
    /**
     * Editable image tile text.
     *
     * @type {ImageTileText}
     */
    public imageTileText: ImageTileText;

    /**
     * Form group.
     *
     * @type {FormGroup}
     */
    public formGroup: FormGroup;

    /**
     * Constructor.
     *
     * @param {MatDialogRef<ImageTileTextFormDialogComponent>} dialogRef
     * @param {any} data
     */
    public constructor(
        public dialogRef: MatDialogRef<ImageTileTextFormDialogComponent>,
        @Inject(MAT_DIALOG_DATA) data: any
    )
    {
        this.imageTileText = data.imageTileText;
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
            value: new FormControl(this.imageTileText.value, [Validators.required, Validators.minLength(3)]),
            unit: new FormControl(this.imageTileText.unit, [Validators.required, Validators.minLength(3)]),
        });
    }

    /**
     * Saves the image tile label data from the form.
     *
     * @returns {void}
     */
    public save(): void
    {
        if (this.formGroup.invalid)
        {
            this.formGroup.markAllAsTouched();

            return;
        }

        this.imageTileText.value = this.formGroup.get('value').value;
        this.imageTileText.unit = this.formGroup.get('unit').value;

        this.dialogRef.close(this.imageTileText);
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
