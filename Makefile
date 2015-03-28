mk_bin_obj_dirs=$1/bin $1/obj 

PROJECTS:=\
	antlr.runtime.Android \
	antlr.runtime.iOS \
	DDay.Collections.Android \
	DDay.Collections.iOS \
	DDay.Collections.Test.Android \
	DDay.Collections.Test.iOS \
	DDay.iCal.Android \
	DDay.iCal.iOS \
	DDay.iCal.Test.Android \
	DDay.iCal.Test.iOS \

DIRS:= \
	$(foreach dir,$(PROJECTS),$(call mk_bin_obj_dirs,$(dir))) \

all:
	/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool build DDay.iCal.Mobile.sln

clean:
	/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool build --target:Clean DDay.iCal.Mobile.sln
	@sh -c "for d in $(DIRS); do echo Cleaning \$$d; rm -fr \$$d; done"

