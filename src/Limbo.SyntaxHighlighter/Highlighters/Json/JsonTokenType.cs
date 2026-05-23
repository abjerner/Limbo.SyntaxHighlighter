namespace Limbo.SyntaxHighlighter.Highlighters.Json;

/// <summary>
/// Enum class indicating the type of the <see cref="JsonToken"/>.
/// </summary>
public enum JsonTokenType {

    /// <summary>
    /// Indicates that the token is a single-line comment.
    /// </summary>
    Comment,

    /// <summary>
    /// Indicates that the token is a multi-line block comment.
    /// </summary>
    BlockComment,

    /// <summary>
    /// Indicates that the token is an open object character.
    /// </summary>
    ObjectOpen,

    /// <summary>
    /// Indicates that the token is a closing object character.
    /// </summary>
    ObjectClose,

    /// <summary>
    /// Indicates that the token is an open array character.
    /// </summary>
    ArrayOpen,

    /// <summary>
    /// Indicates that the token is a closing object character.
    /// </summary>
    ArrayClose,

    /// <summary>
    /// Indicates that the token is a constant value - e.g. a boolean.
    /// </summary>
    Constant,

    /// <summary>
    /// Indicates that the token is a number.
    /// </summary>
    Number,

    /// <summary>
    /// Indicates that the token is a string.
    /// </summary>
    String,

    /// <summary>
    /// Indicates that the token is of an unknown type.
    /// </summary>
    Other

}