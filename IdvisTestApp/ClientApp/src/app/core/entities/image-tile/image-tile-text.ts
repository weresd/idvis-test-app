import * as _ from 'lodash';

export class ImageTileText
{
    /**
     * Image tile label position.
     *
     * @type {mumber}
     */
    public position: number;

    /**
     * Image tile label value.
     *
     * @type {string}
     */
    public value: string;

    /**
     * Image tile label unit.
     *
     * @type {string}
     */
    public unit: string;

    /**
     * Is empty text flag.
     *
     * @returns {boolean}
     */
    public get isEmpty(): boolean
    {
        return (!this.value || this.value.length == 0) && (!this.unit || this.unit.length == 0);
    }

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

        if (data.value && _.isString(data.value))
        {
            this.value = data.value;
        }

        if (data.unit && _.isString(data.unit))
        {
            this.unit = data.unit;
        }
    }
}
