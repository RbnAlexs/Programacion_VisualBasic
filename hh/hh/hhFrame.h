#ifndef HHFRAME_H
#define HHFRAME_H

#include "hh_GUI.h"

class hhFrame : public MainFrame
{
public:
	hhFrame( wxWindow *parent = NULL, int id = -1 );
	~hhFrame();
private:
	void OnExit( wxCommandEvent& event );
	void OnAbout( wxCommandEvent& event );
	DECLARE_EVENT_TABLE();
};
#endif // HHFRAME_H
