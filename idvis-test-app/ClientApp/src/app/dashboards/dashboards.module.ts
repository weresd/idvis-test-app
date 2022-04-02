import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { CoreModule } from '@app/core';
import { ConfirmDialogComponent, SharedModule } from '@app/shared';
import { DashboardsBodyComponent, DashboardsBodyResolver } from './components';
import { DashboardsRoutingModule } from './dashboards-routing.module';

@NgModule({
    declarations: [
        DashboardsBodyComponent
    ],
    imports: [
        CoreModule,
        ReactiveFormsModule,
        RouterModule,
        CommonModule,
        SharedModule,
        DashboardsRoutingModule
    ],
    exports: [],
    providers: [
        DashboardsBodyResolver
    ],
    entryComponents: [
        ConfirmDialogComponent
    ]
})
export class DashboardsModule { }
