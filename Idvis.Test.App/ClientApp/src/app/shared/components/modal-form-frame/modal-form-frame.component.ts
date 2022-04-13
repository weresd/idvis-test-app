import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
    selector: 'app-modal-form-frame',
    templateUrl: './modal-form-frame.component.html',
    styleUrls: ['./modal-form-frame.component.scss']
})
export class ModalFormFrameComponent
{
    /**
     * Modal title.
     *
     * @type {string}
     */
    @Input() title: string;

    /**
     * Confirm button text.
     *
     * @type {string}
     */
    @Input() confirmButtonText: string = 'OK';

    /**
     * Cancel button text.
     *
     * @type {string}
     */
    @Input() cancelButtonText: string = 'Cancel';

    /**
     * Confirm event.
     *
     * @type {EventEmitter<void>}
     */
    @Output() confirm: EventEmitter<void> = new EventEmitter<void>();

    /**
     * Cancel event.
     *
     * @type {EventEmitter<void>}
     */
    @Output() cancel: EventEmitter<void> = new EventEmitter<void>();
}
