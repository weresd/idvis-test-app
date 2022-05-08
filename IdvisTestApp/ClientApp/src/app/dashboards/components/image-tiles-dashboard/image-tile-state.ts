import { ImageTile } from '@app/core';

export class ImageTileState
{
    /**
     * Is new mark.
     *
     * @type {boolean}
     */
    public isNew: boolean = false;

    /**
     * Is changed mark.
     *
     * @type {boolean}
     */
    public isСhanged: boolean = false;

    /**
     * To delete mark.
     *
     * @type {boolean}
     */
    public toDelete: boolean = false;

    /**
     * Image tile data.
     *
     * @type {ImageTile}
     */
    public tile: ImageTile;

    /**
     * Constructor.
     *
     * @param {ImageTile} tile
     */
    public constructor(tile: ImageTile)
    {
        this.tile = tile;
    }

    /**
     * Marks the state as new.
     *
     * @returns {this}
     */
    public markAsNew(): this
    {
        this.isNew = true;

        return this;
    }

    /**
     * Marks the state as changed.
     *
     * @returns {this}
     */
    public markAsСhanged(): this
    {
        this.isСhanged = true;

        return this;
    }

    /**
     * Marks a state for deletion.
     *
     * @returns {this}
     */
    public markToDelete(): this
    {
        this.toDelete = true;

        return this;
    }
}
