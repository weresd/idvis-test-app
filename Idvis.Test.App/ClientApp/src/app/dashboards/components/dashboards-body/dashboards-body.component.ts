import { OnInit, Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { take, tap } from 'rxjs/operators';

import { RepositoriesFabrica, SpinnerService } from '@app/core';

@Component({
    selector: 'app-dashboards-body',
    templateUrl: './dashboards-body.component.html',
    styleUrls: ['./dashboards-body.component.scss']
})
export class DashboardsBodyComponent implements OnInit
{
    /**
     * Constructor.
     *
     * @param {ActivatedRoute} activatedRoute
     * @param {RepositoriesFabrica} repositoriesFabrica
     * @param {SpinnerService} spinnerService
     * @param {MatDialog} dialogService
     * @param {MatSnackBar} snackBarService
     */
    public constructor(
        private activatedRoute: ActivatedRoute,
        private repositoriesFabrica: RepositoriesFabrica,
        private spinnerService: SpinnerService,
        private dialogService: MatDialog
    )
    {
        return;
    }

    /**
     * {@inheritdoc}
     */
    public ngOnInit(): void
    {
        this.activatedRoute.data
            .pipe(
                take(1),
                tap(() => this.spinnerService.hide())
            )
            .subscribe(routeData => {
                return;
            });
    }
}
