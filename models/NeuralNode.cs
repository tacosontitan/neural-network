namespace NeuralNetworkTest;
public class NeuralNode {

    #region Properties

    public double Value { get; set; }
    public List<NeuralNode> ConnectedNodes { get; private set; } = new List<NeuralNode>();

    #endregion

    #region Constructor

    public NeuralNode(double value) => Value = value;

    #endregion
    
}