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
        this.browserTitle.setTitle(title);
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
}
