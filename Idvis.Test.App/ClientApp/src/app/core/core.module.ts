import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatMenuModule } from '@angular/material/menu';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { RouterModule } from '@angular/router';

import { Storages, LocalStorage } from './storages';
import { UserMenuComponent } from './components';
import { BodyComponent, HeaderComponent, MainMenuComponent, PageNotFoundComponent, SpinnerComponent } from './components';
import { UserRepository, GroupRepository, RepositoriesFabrica, PermissionRepository } from './entities';
import { SharedModule } from '@app/shared';

@NgModule({
    declarations: [
        BodyComponent,
        HeaderComponent,
        SpinnerComponent,
        MainMenuComponent,
        PageNotFoundComponent,
        UserMenuComponent,
    ],
    imports: [
        CommonModule,
        SharedModule,
        RouterModule,
        MatToolbarModule,
        MatIconModule,
        MatButtonModule,
        MatProgressBarModule,
        MatListModule,
        MatSidenavModule,
        MatMenuModule,
        MatMenuModule
    ],
    exports: [
        BodyComponent,
        PageNotFoundComponent,
    ],
    providers: [
        UserRepository,
        GroupRepository,
        PermissionRepository,
        Storages,
        LocalStorage,
        RepositoriesFabrica
    ]
})
export class CoreModule { }
