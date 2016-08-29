import LinkUtility = require('./LinkUtility');
import Navigation = require('navigation');
import InfernoComponent = require('inferno-component');
import createElement = require('inferno-create-element');

class NavigationLink extends InfernoComponent {
    private onNavigate = () => this.forceUpdate();
    
    private getStateNavigator(): Navigation.StateNavigator {
        return this.props.stateNavigator || (<any> this.context).stateNavigator;
    }
    
    private getNavigationLink(): string {
        var navigationData = LinkUtility.getData(this.getStateNavigator(), this.props.navigationData, this.props.includeCurrentData, this.props.currentDataKeys);
        return LinkUtility.getLink(this.getStateNavigator(), () => this.getStateNavigator().getNavigationLink(this.props.stateKey, navigationData));
    }
    
    componentDidMount() {
        if (!this.props.lazy)
            this.getStateNavigator().onNavigate(this.onNavigate);
    }
    
    componentWillUnmount() {
        if (!this.props.lazy)
            this.getStateNavigator().offNavigate(this.onNavigate);
    }
    
    render() {
        var props: any = { ref: 'el' };
        for(var key in this.props) {
            if (LinkUtility.isValidAttribute(key))
                props[key] = this.props[key];
        }
        props.href = this.getNavigationLink();
        LinkUtility.addListeners(this, this.getStateNavigator(), this.props, props, () => this.getNavigationLink());
        if (this.getStateNavigator().stateContext.state && this.getStateNavigator().stateContext.state.key === this.props.stateKey)
            LinkUtility.setActive(this.getStateNavigator(), this.props, props);
        return createElement('a', props, this.props.children);
    }
};
export = NavigationLink;
