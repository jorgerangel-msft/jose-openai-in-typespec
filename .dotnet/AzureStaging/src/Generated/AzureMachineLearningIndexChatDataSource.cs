// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> Represents a data source configuration that will use an Azure Machine Learning vector index. </summary>
    public partial class AzureMachineLearningIndexChatDataSource : AzureChatDataSource
    {
        /// <summary> Initializes a new instance of <see cref="AzureMachineLearningIndexChatDataSource"/>. </summary>
        /// <param name="internalParameters"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="internalParameters"/> is null. </exception>
        internal AzureMachineLearningIndexChatDataSource(InternalAzureMachineLearningIndexChatDataSourceParameters internalParameters)
        {
            Argument.AssertNotNull(internalParameters, nameof(internalParameters));

            Type = "azure_ml_index";
            InternalParameters = internalParameters;
        }
    }
}