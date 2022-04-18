import { DragDropModule } from '@angular/cdk/drag-drop';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDividerModule } from '@angular/material/divider';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatMenuModule } from '@angular/material/menu';
import { RouterModule } from '@angular/router';

import { CoreModule } from '@app/core';
import { ConfirmDialogComponent, SharedModule } from '@app/shared';
import { ImageTileComponent, ImageTileWindowsService, TileMenuComponent } from './components';
import { ImageTilesDashboardComponent, ImageTilesDashboardResolver, ImageTileFormDialogComponent } from './components';
import { DashboardsRoutingModule } from './dashboards-routing.module';

@NgModule({
    declarations: [
        ImageTilesDashboardComponent,
        ImageTileFormDialogComponent,
        TileMenuComponent,
        ImageTileComponent
    ],
    imports: [
        CoreModule,
        ReactiveFormsModule,
        RouterModule,
        CommonModule,
        SharedModule,
        DashboardsRoutingModule,
        MatFormFieldModule,
        MatDialogModule,
        MatInputModule,
        MatButtonModule,
        MatIconModule,
        MatMenuModule,
        MatDividerModule,
        DragDropModule
    ],
    exports: [],
    providers: [
        ImageTilesDashboardResolver,
        ImageTileWindowsService
    ],
    entryComponents: [
        ConfirmDialogComponent,
        ImageTileFormDialogComponent,
    ]
})
export class DashboardsModule { }
