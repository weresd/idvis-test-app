import * as _ from 'lodash';

import { Tile } from '../tile';

export class ImageTile extends Tile
{
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

        if (data.img && _.isString(data.img))
        {
            this.img = data.img;
        }
    }
}
