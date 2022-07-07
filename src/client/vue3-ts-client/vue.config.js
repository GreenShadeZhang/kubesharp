const { defineConfig } = require("@vue/cli-service");

const path = require('path')

const AutoImport = require('unplugin-auto-import/webpack');
const Components = require('unplugin-vue-components/webpack');
const ElementPlus = require('unplugin-element-plus/webpack');
const { ElementPlusResolver } = require('unplugin-vue-components/resolvers');

module.exports = defineConfig({
  transpileDependencies: true,
  pluginOptions: {
    'style-resources-loader': {
      preProcessor: 'scss',
      patterns: [
        path.resolve(__dirname, 'src/styles/variables.scss'),
        path.resolve(__dirname, 'src/styles/mixins.scss')
      ]
    }
  },
  configureWebpack: {
    plugins: [
      AutoImport({
        // global imports to register
        imports: [
          // presets
          'vue',
          'vue-router',
          // custom
          {
            'axios':[
              ['axios']
            ]
          },
        ],
        dts: true, // or a custom path
        vueTemplate: true,
        eslintrc: {
          enabled: true,
        },
        resolvers: [ElementPlusResolver()],
      }),
      Components({
        dts: true, // or a custom path
        resolvers: [ElementPlusResolver()],
      }),
      ElementPlus({
        dts: true, // or a custom path
        resolvers: [ElementPlusResolver()],
      }),
    ],
  }
});
