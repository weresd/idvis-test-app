import * as _ from 'lodash';
import { id } from '@app/shared';

export class EntityBase
{
    /**
     * Entity ID.
     *
     * @type {id}
     */
    public id: id = null;

    /**
     * Constructor.
     *
     * @param {object} data
     */
    public constructor(data: any = {})
    {
        if (data.id && _.isString(data.id))
        {
            this.id = data.id;
        }
    }
}
