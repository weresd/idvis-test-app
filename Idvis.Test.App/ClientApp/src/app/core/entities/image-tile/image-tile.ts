import * as _ from 'lodash';

import { Tile } from '../tile';
import { ImageFile } from './image-file';

export class ImageTile extends Tile
{
    /**
     * Tile image.
     *
     * @type {string}
     */
    public image: ImageFile;

    /**
     * Constructor.
     *
     * @param {any} data
     */
    public constructor(data: any = {})
    {
        super(data);

        this.image = new ImageFile();

        if (data.img)
        {
            if (data.img instanceof ImageFile) {
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
