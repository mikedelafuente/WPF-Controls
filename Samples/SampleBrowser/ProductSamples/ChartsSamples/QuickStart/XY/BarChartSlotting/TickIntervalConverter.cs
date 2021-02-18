﻿using System;
using System.Globalization;
#if WINRT
using Windows.UI.Xaml.Data;
#else
using System.Windows.Data;
#endif

namespace ActiproSoftware.ProductSamples.ChartsSamples.QuickStart.XY.BarChartSlotting {

	/// <summary>
	/// Converts the value into a label for a slot interval specifying number of months.
	/// </summary>
	public class TickIntervalConverter : IValueConverter {

		/////////////////////////////////////////////////////////////////////////////////////////////////////
		#region PUBLIC PROCEDURES
		/////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Modifies the source data before passing it to the target for display in the UI.
		/// </summary>
		/// <param name="value">The source data being passed to the target.</param>
		/// <param name="targetType">The <see cref="T:System.Type" /> of data expected by the target dependency property.</param>
		/// <param name="parameter">An optional parameter to be used in the converter logic.</param>
		/// <param name="culture">The culture of the conversion.</param>
		/// <returns>The value to be passed to the target dependency property.</returns>
		#if WINRT
		public object Convert(object value, Type targetType, object parameter, string culture) {
		#else
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
		#endif
			var doubleValue = Math.Ceiling(System.Convert.ToDouble(value));
			int intValue = System.Convert.ToInt32(doubleValue);

			if (intValue == 0)
				return 1;
			if (intValue == 1)
				return 2;
			if(intValue == 2)
				return 4;
			if (intValue == 3)
				return 6;
			if (intValue == 4)
				return 8;

			return 10;
		}

		/// <summary>
		/// Modifies the target data before passing it to the source object.  This method is called only in <see cref="F:System.Windows.Data.BindingMode.TwoWay" /> bindings.
		/// </summary>
		/// <param name="value">The target data being passed to the source.</param>
		/// <param name="targetType">The <see cref="T:System.Type" /> of data expected by the source object.</param>
		/// <param name="parameter">An optional parameter to be used in the converter logic.</param>
		/// <param name="culture">The culture of the conversion.</param>
		/// <returns>The value to be passed to the source object.</returns>
		/// <exception cref="System.NotImplementedException"></exception>
		#if WINRT
		public object ConvertBack(object value, Type targetType, object parameter, string culture) {
		#else
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
		#endif
			throw new NotImplementedException();
		}

		#endregion PUBLIC PROCEDURES

	}
}
