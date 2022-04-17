import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ImageTilesDashboardComponent, ImageTilesDashboardResolver } from './components';

const routes: Routes = [
    {
        path: 'images',
        component: ImageTilesDashboardComponent,
        resolve: {
            requestData: ImageTilesDashboardResolver
        }
    },
    {
        path: '',
        redirectTo: 'images'
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DashboardsRoutingModule { }
