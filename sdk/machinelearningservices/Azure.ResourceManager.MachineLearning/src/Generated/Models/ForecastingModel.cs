// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum for all forecasting models supported by AutoML. </summary>
    public readonly partial struct ForecastingModel : IEquatable<ForecastingModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ForecastingModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ForecastingModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoArimaValue = "AutoArima";
        private const string ProphetValue = "Prophet";
        private const string NaiveValue = "Naive";
        private const string SeasonalNaiveValue = "SeasonalNaive";
        private const string AverageValue = "Average";
        private const string SeasonalAverageValue = "SeasonalAverage";
        private const string ExponentialSmoothingValue = "ExponentialSmoothing";
        private const string ArimaxValue = "Arimax";
        private const string TCNForecasterValue = "TCNForecaster";
        private const string ElasticNetValue = "ElasticNet";
        private const string GradientBoostingValue = "GradientBoosting";
        private const string DecisionTreeValue = "DecisionTree";
        private const string KNNValue = "KNN";
        private const string LassoLarsValue = "LassoLars";
        private const string SGDValue = "SGD";
        private const string RandomForestValue = "RandomForest";
        private const string ExtremeRandomTreesValue = "ExtremeRandomTrees";
        private const string LightGBMValue = "LightGBM";
        private const string XGBoostRegressorValue = "XGBoostRegressor";

        /// <summary>
        /// Auto-Autoregressive Integrated Moving Average (ARIMA) model uses time-series data and statistical analysis to interpret the data and make future predictions.
        /// This model aims to explain data by using time series data on its past values and uses linear regression to make predictions.
        /// </summary>
        public static ForecastingModel AutoArima { get; } = new ForecastingModel(AutoArimaValue);
        /// <summary>
        /// Prophet is a procedure for forecasting time series data based on an additive model where non-linear trends are fit with yearly, weekly, and daily seasonality, plus holiday effects.
        /// It works best with time series that have strong seasonal effects and several seasons of historical data. Prophet is robust to missing data and shifts in the trend, and typically handles outliers well.
        /// </summary>
        public static ForecastingModel Prophet { get; } = new ForecastingModel(ProphetValue);
        /// <summary> The Naive forecasting model makes predictions by carrying forward the latest target value for each time-series in the training data. </summary>
        public static ForecastingModel Naive { get; } = new ForecastingModel(NaiveValue);
        /// <summary> The Seasonal Naive forecasting model makes predictions by carrying forward the latest season of target values for each time-series in the training data. </summary>
        public static ForecastingModel SeasonalNaive { get; } = new ForecastingModel(SeasonalNaiveValue);
        /// <summary> The Average forecasting model makes predictions by carrying forward the average of the target values for each time-series in the training data. </summary>
        public static ForecastingModel Average { get; } = new ForecastingModel(AverageValue);
        /// <summary> The Seasonal Average forecasting model makes predictions by carrying forward the average value of the latest season of data for each time-series in the training data. </summary>
        public static ForecastingModel SeasonalAverage { get; } = new ForecastingModel(SeasonalAverageValue);
        /// <summary> Exponential smoothing is a time series forecasting method for univariate data that can be extended to support data with a systematic trend or seasonal component. </summary>
        public static ForecastingModel ExponentialSmoothing { get; } = new ForecastingModel(ExponentialSmoothingValue);
        /// <summary>
        /// An Autoregressive Integrated Moving Average with Explanatory Variable (ARIMAX) model can be viewed as a multiple regression model with one or more autoregressive (AR) terms and/or one or more moving average (MA) terms.
        /// This method is suitable for forecasting when data is stationary/non stationary, and multivariate with any type of data pattern, i.e., level/trend /seasonality/cyclicity.
        /// </summary>
        public static ForecastingModel Arimax { get; } = new ForecastingModel(ArimaxValue);
        /// <summary> TCNForecaster: Temporal Convolutional Networks Forecaster. </summary>
        public static ForecastingModel TCNForecaster { get; } = new ForecastingModel(TCNForecasterValue);
        /// <summary> Elastic net is a popular type of regularized linear regression that combines two popular penalties, specifically the L1 and L2 penalty functions. </summary>
        public static ForecastingModel ElasticNet { get; } = new ForecastingModel(ElasticNetValue);
        /// <summary> The technique of transiting week learners into a strong learner is called Boosting. The gradient boosting algorithm process works on this theory of execution. </summary>
        public static ForecastingModel GradientBoosting { get; } = new ForecastingModel(GradientBoostingValue);
        /// <summary>
        /// Decision Trees are a non-parametric supervised learning method used for both classification and regression tasks.
        /// The goal is to create a model that predicts the value of a target variable by learning simple decision rules inferred from the data features.
        /// </summary>
        public static ForecastingModel DecisionTree { get; } = new ForecastingModel(DecisionTreeValue);
        /// <summary>
        /// K-nearest neighbors (KNN) algorithm uses &apos;feature similarity&apos; to predict the values of new datapoints
        /// which further means that the new data point will be assigned a value based on how closely it matches the points in the training set.
        /// </summary>
        public static ForecastingModel KNN { get; } = new ForecastingModel(KNNValue);
        /// <summary> Lasso model fit with Least Angle Regression a.k.a. Lars. It is a Linear Model trained with an L1 prior as regularizer. </summary>
        public static ForecastingModel LassoLars { get; } = new ForecastingModel(LassoLarsValue);
        /// <summary>
        /// SGD: Stochastic gradient descent is an optimization algorithm often used in machine learning applications
        /// to find the model parameters that correspond to the best fit between predicted and actual outputs.
        /// It&apos;s an inexact but powerful technique.
        /// </summary>
        public static ForecastingModel SGD { get; } = new ForecastingModel(SGDValue);
        /// <summary>
        /// Random forest is a supervised learning algorithm.
        /// The &quot;forest&quot; it builds, is an ensemble of decision trees, usually trained with the “bagging” method.
        /// The general idea of the bagging method is that a combination of learning models increases the overall result.
        /// </summary>
        public static ForecastingModel RandomForest { get; } = new ForecastingModel(RandomForestValue);
        /// <summary> Extreme Trees is an ensemble machine learning algorithm that combines the predictions from many decision trees. It is related to the widely used random forest algorithm. </summary>
        public static ForecastingModel ExtremeRandomTrees { get; } = new ForecastingModel(ExtremeRandomTreesValue);
        /// <summary> LightGBM is a gradient boosting framework that uses tree based learning algorithms. </summary>
        public static ForecastingModel LightGBM { get; } = new ForecastingModel(LightGBMValue);
        /// <summary> XGBoostRegressor: Extreme Gradient Boosting Regressor is a supervised machine learning model using ensemble of base learners. </summary>
        public static ForecastingModel XGBoostRegressor { get; } = new ForecastingModel(XGBoostRegressorValue);
        /// <summary> Determines if two <see cref="ForecastingModel"/> values are the same. </summary>
        public static bool operator ==(ForecastingModel left, ForecastingModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ForecastingModel"/> values are not the same. </summary>
        public static bool operator !=(ForecastingModel left, ForecastingModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ForecastingModel"/>. </summary>
        public static implicit operator ForecastingModel(string value) => new ForecastingModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ForecastingModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ForecastingModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
