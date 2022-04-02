import { Injectable } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class TitleService
{
    /**
     * Application title state.
     *
     * @type {BehaviorSubject<string>}
     */
    public readonly appTitle$: BehaviorSubject<string> = new BehaviorSubject<string>('');

    /**
     * Page title state.
     *
     * @type {BehaviorSubject<string>}
     */
    public readonly pageTitle$: BehaviorSubject<string> = new BehaviorSubject<string>('');

    /**
     * Constructor.
     *
     * @param {Title} browserTitle
     */
    public constructor(public browserTitle: Title)
    {
        this.appTitle$.subscribe({
            next: appTitle => this.updateBrowserTitle(appTitle, this.pageTitle$.getValue())
        });

        this.pageTitle$.subscribe({
            next: pageTitle => this.updateBrowserTitle(this.appTitle$.getValue(), pageTitle)
        });

        return;
    }

    /**
     * Sets app title.
     *
     * @param {string} title
     *
     * @returns {TitleService}
     */
    public setAppTitle(title: string): this
    {
        this.appTitle$.next(title);

        return this;
    }

    /**
     * Sets page title.
     *
     * @param {string} title
     *
     * @returns {TitleService}
     */
    public setPageTitle(title: string): this
    {
        this.pageTitle$.next(title);

        return this;
    }

    /**
     * Updates browser title.
     *
     * @param {string} appTitle
     * @param {string} pageTitle
     *
     * @returns {void}
     */
    private updateBrowserTitle(appTitle: string, pageTitle: string): void
    {
        let browserTitle = '';

        if (appTitle.length > 0) {
            browserTitle += appTitle;

            if (pageTitle.length > 0) {
                browserTitle += ' | ' + pageTitle;
            }
        }

        this.browserTitle.setTitle(browserTitle);
    }
}
