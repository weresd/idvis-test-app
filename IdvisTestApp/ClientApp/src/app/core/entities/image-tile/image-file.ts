export class ImageFile
{
    /**
     * Image remote URL.
     *
     * @type {string}
     */
    public remoteUrl: string = '';

    /**
     * The content of the local image file.
     *
     * @type {string}
     */
    public localFileContent: string = '';

    /**
     * Information about the local image file.
     *
     * @type {File}
     */
    public localFile: File;

    /**
     * Returns the source of the image.
     *
     * @returns {string}
     */
    public get src(): string
    {
        if (this.localFileContent.length > 0)
        {
            return this.localFileContent;
        }

        if (this.remoteUrl.length > 0)
        {
            return this.remoteUrl;
        }

        return '';
    }

    /**
     * Returns the name of the image.
     *
     * @returns {string}
     */
    public get name(): string
    {
        if (this.localFile instanceof File)
        {
            return this.localFile.name;
        }

        if (this.remoteUrl.length > 0)
        {
            return this.remoteUrl;
        }

        return '';
    }

    /**
     * Sets information about the local file and loads the contents of the local file.
     *
     * @param {File} file
     */
    public set file(file: File)
    {
        this.localFile = file;

        const fileReader = new FileReader();

        fileReader.onloadend = () => this.localFileContent = (fileReader.result as string);
        fileReader.readAsDataURL(this.localFile);
    }
}
