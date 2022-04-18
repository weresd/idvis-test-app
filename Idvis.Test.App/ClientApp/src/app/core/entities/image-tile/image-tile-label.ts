import * as _ from 'lodash';

export class ImageTileLabel
{
    /**
     * Image tile label position.
     *
     * @type {mumber}
     */
    public position: number;

    /**
     * Image tile label text.
     *
     * @type {string}
     */
    public text: string;

    /**
     * Image tile label unit.
     *
     * @type {string}
     */
    public unit: string;

    /**
     * Constructor.
     *
     * @param {any} data
     */
    public constructor(data: any = {})
    {
        if (data.position && _.isNumber(data.position))
        {
            this.position = data.position;
        }

        if (data.text && _.isNumber(data.text))
        {
            this.text = data.text;
        }

        if (data.unit && _.isNumber(data.unit))
        {
            this.unit = data.unit;
        }
    }
}
