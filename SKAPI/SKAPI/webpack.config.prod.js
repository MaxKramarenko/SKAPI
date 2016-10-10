plugins: [

  new webpack.optimize.UglifyJsPlugin({
        compressor: {
        warnings: false
  }
  }),
  new ExtractTextPlugin('styles.css')
]