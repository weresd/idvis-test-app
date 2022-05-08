import * as _ from 'lodash';

import { EntityBase } from '../entity.base';

export abstract class Tile extends EntityBase
{
    /**
     * Tile title.
     *
     * @type {string}
     */
    public title: string;

    /**
     * Constructor.
     *
     * @param {any} data
     */
    public constructor(data: any = {})
    {
        super(data);

        if (data.title && _.isString(data.title))
        {
            this.title = data.title;
        }
    }
}
