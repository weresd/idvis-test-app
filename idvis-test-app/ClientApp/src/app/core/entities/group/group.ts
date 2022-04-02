import * as _ from 'lodash';
import { INamedEntity } from '@app/shared';

import { EntityBase } from '../entity.base';

export class Group extends EntityBase implements INamedEntity
{
    /**
     * Group name.
     *
     * @type {string}
     */
    public name: string;

    /**
     * List of group permissions.
     *
     * @type {string[]}
     */
     public permissions: string[] = [];

    /**
     * Constructor.
     *
     * @param {any} data
     */
    public constructor(data: any = {})
    {
        super(data);

        if (data.name && _.isString(data.name))
        {
            this.name = data.name;
        }

        if (data.permissions && _.isArray(data.permissions))
        {
            this.permissions = data.permissions;
        }
    }
}
