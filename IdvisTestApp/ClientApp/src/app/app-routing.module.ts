import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PageNotFoundComponent } from './core';

const routes: Routes = [
    {
        path: '',
        redirectTo: 'dashboards',
        pathMatch: 'full'
    },
    {
        path: 'user-management',
        loadChildren: () => import('./user-management').then(m => m.UserManagementModule)
    },
    {
        path: 'dashboards',
        loadChildren: () => import('./dashboards').then(m => m.DashboardsModule)
    },
    {
        path: '**',
        component: PageNotFoundComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes, { useHash: true, relativeLinkResolution: 'legacy' })],
    exports: [RouterModule]
})
export class AppRoutingModule { }
