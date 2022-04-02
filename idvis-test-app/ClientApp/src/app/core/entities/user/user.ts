import * as _ from 'lodash';
import { INamedEntity } from '@app/shared';

import { EntityBase } from '../entity.base';

export class User extends EntityBase implements INamedEntity
{
    /**
     * User name.
     *
     * @type {string}
     */
    public name: string;

    /**
     * User login.
     *
     * @type {string}
     */
    public login: string;

    /**
     * User email.
     *
     * @type {string}
     */
    public email: string;

    /**
     * List of user permissions.
     *
     * @type {string[]}
     */
    public permissions: string[] = [];

    /**
     * List of user groups.
     *
     * @type {string[]}
     */
    public groups: string[] = [];

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

        if (data.login && _.isString(data.login))
        {
            this.login = data.login;
        }

        if (data.email && _.isString(data.email))
        {
            this.email = data.email;
        }

        if (data.permissions && _.isArray(data.permissions))
        {
            this.permissions = data.permissions;
        }

        if (data.groups && _.isArray(data.groups))
        {
            this.groups = data.groups;
        }
    }
}
