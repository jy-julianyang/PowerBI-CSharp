namespace Microsoft.PowerBI.Api
{
    /// <summary>
    /// Represents a tile in Power BI.
    /// </summary>
    public interface ITile
    {
        /// <summary>
        /// Gets or sets the ID of the tile.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the tile.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the URL for embedding the tile.
        /// </summary>
        string EmbedUrl { get; set; }
    }
}
