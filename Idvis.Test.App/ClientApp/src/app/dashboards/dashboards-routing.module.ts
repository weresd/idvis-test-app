import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardsBodyComponent, DashboardsBodyResolver } from './components';

const routes: Routes = [
    {
        path: '',
        component: DashboardsBodyComponent,
        resolve: {
            requestData: DashboardsBodyResolver
        }
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DashboardsRoutingModule { }
