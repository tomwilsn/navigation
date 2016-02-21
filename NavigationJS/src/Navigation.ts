﻿import StateContext = require('./StateContext');
import StateController = require('./StateController');
import State = require('./config/State');
import HashHistoryManager = require('./history/HashHistoryManager');
import HTML5HistoryManager = require('./history/HTML5HistoryManager');
import Crumb = require('./config/Crumb');
import StateHandler = require('./config/StateHandler');

class Navigation {
    static State = State;
    static HashHistoryManager = HashHistoryManager;
    static HTML5HistoryManager = HTML5HistoryManager;
    static Crumb = Crumb;
    static StateContext = StateContext;
    static StateController = StateController;
    static StateHandler = StateHandler;
} 
export = Navigation;