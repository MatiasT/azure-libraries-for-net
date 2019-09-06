// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data used when creating a disk.
    /// </summary>
    public partial class CreationData
    {
        /// <summary>
        /// Initializes a new instance of the CreationData class.
        /// </summary>
        public CreationData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreationData class.
        /// </summary>
        /// <param name="createOption">This enumerates the possible sources of
        /// a disk's creation. Possible values include: 'Empty', 'Attach',
        /// 'FromImage', 'Import', 'Copy', 'Restore', 'Upload'</param>
        /// <param name="storageAccountId">If createOption is Import, the Azure
        /// Resource Manager identifier of the storage account containing the
        /// blob to import as a disk. Required only if the blob is in a
        /// different subscription</param>
        /// <param name="imageReference">Disk source information.</param>
        /// <param name="sourceUri">If createOption is Import, this is the URI
        /// of a blob to be imported into a managed disk.</param>
        /// <param name="sourceResourceId">If createOption is Copy, this is the
        /// ARM id of the source snapshot or disk.</param>
        /// <param name="sourceUniqueId">If this field is set, this is the
        /// unique id identifying the source of this resource.</param>
        /// <param name="uploadSizeBytes">If createOption is Upload, this is
        /// the size of the contents of the upload including the VHD footer.
        /// This value should be between 20972032 (20 MiB + 512 bytes for the
        /// VHD footer) and 35183298347520 bytes (32 TiB + 512 bytes for the
        /// VHD footer).</param>
        public CreationData(DiskCreateOption createOption, string storageAccountId = default(string), ImageDiskReference imageReference = default(ImageDiskReference), string sourceUri = default(string), string sourceResourceId = default(string), string sourceUniqueId = default(string), long? uploadSizeBytes = default(long?))
        {
            CreateOption = createOption;
            StorageAccountId = storageAccountId;
            ImageReference = imageReference;
            SourceUri = sourceUri;
            SourceResourceId = sourceResourceId;
            SourceUniqueId = sourceUniqueId;
            UploadSizeBytes = uploadSizeBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this enumerates the possible sources of a disk's
        /// creation. Possible values include: 'Empty', 'Attach', 'FromImage',
        /// 'Import', 'Copy', 'Restore', 'Upload'
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public DiskCreateOption CreateOption { get; set; }

        /// <summary>
        /// Gets or sets if createOption is Import, the Azure Resource Manager
        /// identifier of the storage account containing the blob to import as
        /// a disk. Required only if the blob is in a different subscription
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets disk source information.
        /// </summary>
        [JsonProperty(PropertyName = "imageReference")]
        public ImageDiskReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets if createOption is Import, this is the URI of a blob
        /// to be imported into a managed disk.
        /// </summary>
        [JsonProperty(PropertyName = "sourceUri")]
        public string SourceUri { get; set; }

        /// <summary>
        /// Gets or sets if createOption is Copy, this is the ARM id of the
        /// source snapshot or disk.
        /// </summary>
        [JsonProperty(PropertyName = "sourceResourceId")]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// Gets if this field is set, this is the unique id identifying the
        /// source of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "sourceUniqueId")]
        public string SourceUniqueId { get; private set; }

        /// <summary>
        /// Gets or sets if createOption is Upload, this is the size of the
        /// contents of the upload including the VHD footer. This value should
        /// be between 20972032 (20 MiB + 512 bytes for the VHD footer) and
        /// 35183298347520 bytes (32 TiB + 512 bytes for the VHD footer).
        /// </summary>
        [JsonProperty(PropertyName = "uploadSizeBytes")]
        public long? UploadSizeBytes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CreateOption == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreateOption");
            }
            if (ImageReference != null)
            {
                ImageReference.Validate();
            }
        }
    }
}
