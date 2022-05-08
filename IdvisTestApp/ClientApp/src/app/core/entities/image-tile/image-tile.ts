import * as _ from 'lodash';

import { Tile } from '../tile';
import { ImageFile } from './image-file';
import { ImageTileText } from './image-tile-text';

export class ImageTile extends Tile
{
    /**
     * Tile image.
     *
     * @type {string}
     */
    public image: ImageFile;

    /**
     * Image tile text.
     *
     * @type {ImageTileText[]}
     */
    public texts: ImageTileText[] = [];

    /**
     * Constructor.
     *
     * @param {any} data
     */
    public constructor(data: any = {})
    {
        super(data);

        this.image = new ImageFile();

        if (data.texts && _.isArray(data.texts))
        {
            this.texts = data.texts.map(t => new ImageTileText(t));
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
