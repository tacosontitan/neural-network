namespace NeuralNetworkTest;
/// <summary>
/// Represents a neural network.
/// </summary>
public class NeuralNetwork {

    #region Fields

    private readonly List<NeuralNode> _hiddenNodes;

    #endregion
    
    #region Properties

    /// <summary>
    /// The collection of <see cref="NeuralNode"/> objects that represent the input of this network.
    public List<NeuralNode> InputNodes { get; private set; }
    /// <summary>
    /// The collection of <see cref="NeuralNode"/> objects that represent the output of this network.
    /// </summary>
    public List<NeuralNode> OutputNodes { get; private set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Creates a new instance of a <see cref="NeuralNetwork" /> with the specified collection of <seealso cref="NeuralNode" /> as input.
    /// </summary>
    /// <param name="inputNodes">The collection of <see cref="NeuralNode"/> objects to be used as input for the network.</param>L
    public NeuralNetwork(IEnumerable<NeuralNode> inputNodes) {
        InputNodes = new(inputNodes);
        OutputNodes = new();
        _hiddenNodes = new();
    }

    #endregion

}