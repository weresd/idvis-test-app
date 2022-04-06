import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve } from '@angular/router';
import { forkJoin, Observable, of } from 'rxjs';
import { map, tap } from 'rxjs/operators';

import { RepositoriesFabrica, SpinnerService, TitleService } from '@app/core';

@Injectable()
export class DashboardsBodyResolver implements Resolve<any>
{
    /**
     * Constructor.
     *
     * @param {TitleService} titleService
     * @param {RepositoriesFabrica} repositoriesFabrica
     * @param {SpinnerService} spinnerService
     */
    public constructor(
        private titleService: TitleService,
        private repositoriesFabrica: RepositoriesFabrica,
        private spinnerService: SpinnerService
    )
    {
        return;
    }

    /**
     * Resolves data.
     *
     * @param {ActivatedRouteSnapshot} route
     *
     * @returns {Observable<any>}
     */
    public resolve(route: ActivatedRouteSnapshot): Observable<any>
    {
        this.spinnerService.show();

        return of('temp data').pipe(
            tap(() => this.titleService.setAppTitle('Dashboards').setPageTitle('New Dashboard'))
        );
    }
}
