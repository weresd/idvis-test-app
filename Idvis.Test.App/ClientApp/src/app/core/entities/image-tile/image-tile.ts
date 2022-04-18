import * as _ from 'lodash';

import { Tile } from '../tile';
import { ImageFile } from './image-file';
import { ImageTileLabel } from './image-tile-label';

export class ImageTile extends Tile
{
    /**
     * Tile image.
     *
     * @type {string}
     */
    public image: ImageFile;

    /**
     * Image tile label.
     *
     * @type {ImageTileLabel[]}
     */
    public labels: ImageTileLabel[] = [];

    /**
     * Constructor.
     *
     * @param {any} data
     */
    public constructor(data: any = {})
    {
        super(data);

        this.image = new ImageFile();

        if (data.labels && _.isArray(data.labels))
        {
            this.labels= data.labels;
        }

        if (data.img)
        {
            if (data.img instanceof ImageFile)
            {
                this.image = data.img;
            }

            if (_.isString(data.img))
            {
                this.image.remoteUrl = data.img;
            }

            if (data.img instanceof File)
            {
                this.image.file = data.img;
            }
        }
    }
}
