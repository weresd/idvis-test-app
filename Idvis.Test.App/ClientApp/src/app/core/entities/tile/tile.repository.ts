import { Inject, Injectable } from '@angular/core';

import { Storages } from '../../storages/storages';
import { RepositoryBase } from '../repository.base';
import { Tile } from './tile';

@Injectable()
export class TileRepository extends RepositoryBase<Tile>
{
    /**
     * @inheritdoc
     */
    protected storageKey: string = 'tiles';

    /**
     * @inheritdoc
     */
    protected entityType: any = Tile;

    /**
     * @inheritdoc
     */
    public constructor(@Inject(Storages) storageService: Storages)
    {
        super(storageService);
    }
}
