import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatDividerModule } from '@angular/material/divider';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatListModule } from '@angular/material/list';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatMenuModule } from '@angular/material/menu';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { RouterModule } from '@angular/router';

import { CoreModule } from '@app/core';
import { ConfirmDialogComponent, SharedModule } from '@app/shared';
import { GroupsChangerComponent } from './components';
import { GroupFormDialogComponent, UserViewComponent, GroupViewComponent, PermissionsChangerComponent } from './components';
import { UserManagementDashboardComponent, UserManagementDashboardResolver, UserFormDialogComponent } from './components';
import { UserManagementRoutingModule } from './user-management-routing.module';

@NgModule({
    declarations: [
        UserManagementDashboardComponent,
        UserFormDialogComponent,
        GroupFormDialogComponent,
        UserViewComponent,
        GroupViewComponent,
        PermissionsChangerComponent,
        GroupsChangerComponent
    ],
    imports: [
        CoreModule,
        ReactiveFormsModule,
        RouterModule,
        CommonModule,
        SharedModule,
        UserManagementRoutingModule,
        MatGridListModule,
        MatDividerModule,
        MatMenuModule,
        MatIconModule,
        MatButtonModule,
        MatDialogModule,
        MatSnackBarModule,
        MatInputModule,
        MatFormFieldModule,
        MatExpansionModule,
        MatListModule,
        MatCheckboxModule,
        MatSidenavModule,
        MatTooltipModule
    ],
    exports: [],
    providers: [
        UserManagementDashboardResolver
    ],
    entryComponents: [
        ConfirmDialogComponent,
        UserFormDialogComponent,
        GroupFormDialogComponent
    ]
})
export class UserManagementModule { }
