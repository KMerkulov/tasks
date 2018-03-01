;(function($){
	$.extend( $.ui.tabs.prototype, {
		rotation: null,
		rotationDelay: null,
		continuing: null,
		rotate: function( ms, continuing ) {
			var self = this,
				o = this.options;

			if((ms > 1 || self.rotationDelay === null) && ms !== undefined){//Вставити тільки затримку обертання,якщо це перший раз.
				self.rotationDelay = ms;
			}

			if(continuing !== undefined){
				self.continuing = continuing;
			}

			var rotate = self._rotate || ( self._rotate = function( e ) {
				clearTimeout( self.rotation );
				self.rotation = setTimeout(function() {
					var t = o.selected;
					self.select( ++t < self.anchors.length ? t : 0 );
				}, ms );

				if ( e ) {
					e.stopPropagation();
				}
			});

			var stop = self._unrotate || ( self._unrotate = !continuing
				? function(e) {
					if (e.clientX) { // у разі кліку миші
						self.rotate(null);
					}
				}
				: function( e ) {
					t = o.selected;
					rotate();
				});

			// почати обертання
			if ( ms ) {
				this.element.bind( "tabsshow", rotate );
				this.anchors.bind( o.event + ".tabs", stop );
				rotate();
			// стоп
			} else {
				clearTimeout( self.rotation );
				this.element.unbind( "tabsshow", rotate );
				this.anchors.unbind( o.event + ".tabs", stop );
				delete this._rotate;
				delete this._unrotate;
			}

			//обертатися відразу, а потім нормальну затримку обертання
			if(ms === 1){
				ms = self.rotationDelay;
			}

			return this;
		},
		pause: function() {
			var self = this,
				o = this.options;

			self.rotate(0);
		},
		unpause: function(){
			var self = this,
				o = this.options;

			self.rotate(1, self.continuing);
		}
	});
})(jQuery);