import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ImageTilesDashboardComponent, ImageTilesDashboardResolver } from './components';

const routes: Routes = [
    {
        path: '',
        component: ImageTilesDashboardComponent,
        resolve: {
            requestData: ImageTilesDashboardResolver
        }
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DashboardsRoutingModule { }
