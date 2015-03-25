﻿var browserify = require('browserify');
var gulp = require('gulp');
var derequire = require('gulp-derequire');
var mocha = require('gulp-mocha');
var rename = require('gulp-rename');
var source = require('vinyl-source-stream');
var streamify = require('gulp-streamify');
var uglify = require('gulp-uglify');

gulp.task('test', function () {
	return gulp.src('./test/*.js', { read: false })
        .pipe(mocha({ reporter: 'nyan' }));
});

var items = [
	{ name: 'Navigation', from: './src/Navigation.ts', to: 'navigation.js' },
	{ name: 'NavigationReact', from: './src/react/NavigationReact.ts', to: 'navigation.react.js' },
	{ name: 'NavigationKnockout', from: './src/knockout/NavigationKnockout.ts', to: 'navigation.knockout.js' }
];

function build(name, from, to) {
	browserify(from, { standalone: name })
		.plugin('tsify')
		.bundle()
		.pipe(source(to))
		.pipe(rename(to))
		.pipe(derequire())
		//.pipe(streamify(uglify()))
		.pipe(gulp.dest('./build'))
}

gulp.task('navigate', function () {
	for (var i = 0; i < items.length; i++) {
		var item = items[i];
		build(item.name, item.from, item.to)
	}
});

gulp.task('build', ['test', 'navigate']);