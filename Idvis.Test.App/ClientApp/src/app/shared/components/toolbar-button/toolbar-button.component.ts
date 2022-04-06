import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-toolbar-button',
    templateUrl: './toolbar-button.component.html',
    styleUrls: ['./toolbar-button.component.scss']
})
export class ToolbarButtonComponent
{
    @Input() icon: string = '';
    @Input() text: string = '';
}
