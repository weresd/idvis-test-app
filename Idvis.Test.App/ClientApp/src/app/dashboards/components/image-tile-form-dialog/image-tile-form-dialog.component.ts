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
     * Tile Image File.
     *
     * @type {File}
     */
    public image: File;

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
            title: new FormControl(this.imageTile.title, [Validators.required, Validators.minLength(3)]),
            img_name: new FormControl(this.imageTile.image.name, [Validators.required]),
            image: new FormControl(this.imageTile.image.src, [Validators.required]),
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
            this.formGroup.markAllAsTouched();

            return;
        }

        this.imageTile.title = this.formGroup.get('title').value;

        if (this.image) {
            this.imageTile.image.file = this.image;
        }

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

    /**
     * Clears a image form field.
     *
     * @returns {void}
     */
    public clearImageField(): void
    {
        this.formGroup.get('image').setValue('');
        this.formGroup.get('img_name').setValue('');
        this.formGroup.get('img_name').markAsUntouched();
    }

    /**
     * Change image handler.
     *
     * @param {} event
     *
     * @returns {void}
     */
    public changeImageHandler(event): void
    {
        console.log(event);
        const target = event.target as HTMLInputElement;

        if (target && target.files && target.files[0] instanceof File)
        {
            this.image = (event.target as HTMLInputElement).files[0];

            const reader = new FileReader();
            reader.onload = () => {
                this.formGroup.get('image').setValue(reader.result as string);
                this.formGroup.get('img_name').setValue(this.image.name);
            }
            reader.readAsDataURL(this.image);
        }
    }
}
