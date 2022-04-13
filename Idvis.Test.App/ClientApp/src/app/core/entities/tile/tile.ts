import * as _ from 'lodash';

import { EntityBase } from '../entity.base';

export class Tile extends EntityBase
{
    /**
     * Tile title.
     *
     * @type {string}
     */
    public title: string;

    /**
     * Tile image.
     *
     * @type {string}
     */
    public img: string;

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

        if (data.img && _.isString(data.img))
        {
            this.img = data.img;
        }
    }
}
