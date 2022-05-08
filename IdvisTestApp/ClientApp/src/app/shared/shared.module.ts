import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDividerModule } from '@angular/material/divider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';

import { ToolbarComponent, ToolbarButtonComponent, ModalFormFrameComponent } from './components';
import { EntitiesChangerComponent, ConfirmDialogComponent, DialogButtonsComponent } from './components';
import { SearchBarComponent, ExpansionPanelComponent, CheckboxComponent, ViewRowComponent } from './components';
import { NamedEntitySearchPipe } from './pipes';

@NgModule({
    declarations: [
        EntitiesChangerComponent,
        ConfirmDialogComponent,
        DialogButtonsComponent,
        SearchBarComponent,
        NamedEntitySearchPipe,
        ExpansionPanelComponent,
        CheckboxComponent,
        ViewRowComponent,
        ToolbarComponent,
        ToolbarButtonComponent,
        ModalFormFrameComponent
    ],
    imports: [
        CommonModule,
        MatListModule,
        MatIconModule,
        MatDialogModule,
        MatButtonModule,
        MatDividerModule,
        MatFormFieldModule,
        MatInputModule
    ],
    exports: [
        EntitiesChangerComponent,
        ConfirmDialogComponent,
        DialogButtonsComponent,
        SearchBarComponent,
        NamedEntitySearchPipe,
        ExpansionPanelComponent,
        CheckboxComponent,
        ViewRowComponent,
        ToolbarComponent,
        ToolbarButtonComponent,
        ModalFormFrameComponent
    ],
    providers: []
})
export class SharedModule { }
