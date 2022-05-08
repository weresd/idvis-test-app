import { Inject, Injectable } from '@angular/core';

import { Storages } from '../../storages/storages';
import { RepositoryBase } from '../repository.base';
import { ImageTile } from './image-tile';

@Injectable()
export class ImageTileRepository extends RepositoryBase<ImageTile>
{
    /**
     * @inheritdoc
     */
    protected storageKey: string = 'image-tiles';

    /**
     * @inheritdoc
     */
    protected entityType: any = ImageTile;

    /**
     * @inheritdoc
     */
    public constructor(@Inject(Storages) storageService: Storages)
    {
        super(storageService);
    }
}
