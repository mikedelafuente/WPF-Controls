namespace ActiproSoftware.ProductSamples.SyntaxEditorSamples.QuickStart.GettingStarted04d {
    using ActiproSoftware.Text.Parsing;
    using System;
    using System.Collections.Generic;
    
    
    /// <summary>
    /// Represents a binary operator expression.
    /// </summary>
    /// <remarks>
    /// This type was generated by the Actipro Language Designer tool v11.1.544.0 (http://www.actiprosoftware.com).
    /// Generated code is based on input created by Actipro Software LLC.
    /// Copyright (c) 2001-2021 Actipro Software LLC.  All rights reserved.
    /// </remarks>
    public partial class BinaryOperatorExpression : Expression {
        
        /// <summary>
        /// Gets the left expression.
        /// </summary>
        private Expression leftExpressionValue;
        
        /// <summary>
        /// Gets the operator.
        /// </summary>
        private OperatorKind operatorValue;
        
        /// <summary>
        /// Gets the right expression.
        /// </summary>
        private Expression rightExpressionValue;
        
        /// <summary>
        /// Gets the An integer value that identifies the type of AST node.
        /// </summary>
        /// <value>The An integer value that identifies the type of AST node.</value>
        public override Int32 Id {
            get {
                return SimpleAstNodeId.BinaryOperatorExpression;
            }
        }
        
        /// <summary>
        /// Gets or sets the left expression.
        /// </summary>
        /// <value>The left expression.</value>
        public Expression LeftExpression {
            get {
                return this.leftExpressionValue;
            }
            set {
                this.leftExpressionValue = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>The operator.</value>
        public OperatorKind Operator {
            get {
                return this.operatorValue;
            }
            set {
                this.operatorValue = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the right expression.
        /// </summary>
        /// <value>The right expression.</value>
        public Expression RightExpression {
            get {
                return this.rightExpressionValue;
            }
            set {
                this.rightExpressionValue = value;
            }
        }
        
        /// <summary>
        /// Retrieves an <c>IEnumerator</c> object that can iterate the child <see cref="IAstNode"/> objects in this node.
        /// </summary>
        /// <returns>An <c>IEnumerator</c> object that can iterate the child <see cref="IAstNode"/> objects in this node.</returns>
        protected override IEnumerator<IAstNode> GetChildrenEnumerator() {
            IEnumerator<IAstNode> baseEnumerator = base.GetChildrenEnumerator();
            if ((baseEnumerator != null)) {
				while (baseEnumerator.MoveNext())
					yield return baseEnumerator.Current;
            }
            if ((this.leftExpressionValue != null)) {
				yield return this.leftExpressionValue;
            }
            if ((this.rightExpressionValue != null)) {
				yield return this.rightExpressionValue;
            }
        }
    }
}