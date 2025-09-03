// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function toggleTheme() {
    const body = document.body;
    const current = body.getAttribute('data-theme');
    body.setAttribute('data-theme', current === 'dark' ? 'light' : 'dark');
    document.querySelectorAll('.card').forEach(card => {
        card.setAttribute('data-theme', body.getAttribute('data-theme'));
    });
}

// Theme Toggle Functionality
// site.js

(function () {
    // apply saved theme ASAP to avoid FOUC
    const saved = localStorage.getItem('theme') || 'light';
    document.documentElement.setAttribute('data-theme', saved);

    document.addEventListener('DOMContentLoaded', () => {
        const htmlEl = document.documentElement;        // set data-theme on <html>
        const toggleEl = document.getElementById('themeToggle');

        // If the toggle isn't on this page (or markup mismatch), bail gracefully
        if (!toggleEl) return;

        // Initialize checkbox state from saved theme
        toggleEl.checked = (saved === 'dark');

        // One source of truth: the checkbox
        toggleEl.addEventListener('change', () => {
            const next = toggleEl.checked ? 'dark' : 'light';
            htmlEl.setAttribute('data-theme', next);
            localStorage.setItem('theme', next);
        });
    });
})();



//sidebar functions
document.addEventListener('DOMContentLoaded', () => {
    const sidebar = document.getElementById('sidebar-wrapper');
    if (sidebar) {
        // Restore scroll position
        const savedScroll = localStorage.getItem('sidebarScroll');
        if (savedScroll) sidebar.scrollTop = savedScroll;

        // Save scroll position on unload
        window.addEventListener('beforeunload', () => {
            localStorage.setItem('sidebarScroll', sidebar.scrollTop);
        });
    }
});

document.addEventListener('DOMContentLoaded', () => {
    const sidebar = document.getElementById('sidebar-wrapper');
    const activeNav = document.querySelector('#sidebarMenu .nav-link.active');
    // Scroll to active nav item if present
    if (sidebar && activeNav) {
        const sidebarRect = sidebar.getBoundingClientRect();
        const navRect = activeNav.getBoundingClientRect();
        const offset = navRect.top - sidebarRect.top + sidebar.scrollTop - 40; // 40px for padding
        sidebar.scrollTo({ top: offset, behavior: 'smooth' });
    }
    // Save scroll position on unload
    if (sidebar) {
        window.addEventListener('beforeunload', () => {
            localStorage.setItem('sidebarScroll', sidebar.scrollTop);
        });
    }
});

// Add animation classes when elements come into view
const observerOptions = {
    threshold: 0.1,
    rootMargin: '0px 0px -50px 0px'
};

const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.style.animationPlayState = 'running';
        }
    });
}, observerOptions);

// Observe all animated elements
document.querySelectorAll('.animate-fade-in-up').forEach(el => {
    el.style.animationPlayState = 'paused';
    observer.observe(el);
});

/*Responsive Features*/
/* ===== 2025 RESPONSIVE HELPERS ===== */

// Auto-cardify tables on mobile (adds data-labels from THEAD)
function initResponsiveTable(tableSelector) {
    document.querySelectorAll(tableSelector).forEach(tbl => {
        const headers = Array.from(tbl.querySelectorAll('thead th')).map(th => th.textContent.trim());
        tbl.querySelectorAll('tbody tr').forEach(row => {
            Array.from(row.children).forEach((td, idx) => {
                if (!td.getAttribute('data-label') && headers[idx]) td.setAttribute('data-label', headers[idx]);
            });
        });
    });
}

// Density toggle (attach to a btn or switch)
function bindDensityToggle(wrapperSelector, prefKey = 'tableDensity') {
    const wrapper = document.querySelector(wrapperSelector);
    if (!wrapper) return;
    const saved = localStorage.getItem(prefKey) || 'comfortable';
    wrapper.classList.toggle('table-density-compact', saved === 'compact');
    wrapper.classList.toggle('table-density-comfortable', saved !== 'compact');

    document.querySelectorAll('[data-toggle-density]').forEach(btn => {
        btn.addEventListener('click', () => {
            const nowCompact = !wrapper.classList.contains('table-density-compact');
            wrapper.classList.toggle('table-density-compact', nowCompact);
            wrapper.classList.toggle('table-density-comfortable', !nowCompact);
            localStorage.setItem(prefKey, nowCompact ? 'compact' : 'comfortable');
        });
    });
}

// Show/Hide bulk selection bar when rows are selected
function bindBulkBar(tableSelector, bulkBarSelector) {
    const tbl = document.querySelector(tableSelector);
    const bar = document.querySelector(bulkBarSelector);
    if (!tbl || !bar) return;
    const update = () => {
        const checked = tbl.querySelectorAll('tbody input[type="checkbox"]:checked').length;
        bar.classList.toggle('show', checked > 0);
        const countSpans = bar.querySelectorAll('[data-selected-count]');
        countSpans.forEach(s => s.textContent = checked);
    };
    tbl.addEventListener('change', e => { if (e.target.matches('tbody input[type="checkbox"]')) update(); });
    update();
}

// Simple view toggle (table <-> cards/grid)
function bindViewToggle(containerSel) {
    document.querySelectorAll(`${containerSel} [data-view]`).forEach(btn => {
        btn.addEventListener('click', () => {
            const view = btn.dataset.view; // 'table' | 'grid'
            const container = btn.closest(containerSel);
            container.querySelectorAll('[data-view]').forEach(b => b.classList.toggle('active', b === btn));
            container.querySelectorAll('[data-view-panel]').forEach(p => p.hidden = p.dataset.viewPanel !== view);
        });
    });
}

// Bind offcanvas filter submit -> apply filters (placeholder hook)
function bindFilterApply(offcanvasId, onApply = () => { }) {
    const panel = document.getElementById(offcanvasId);
    if (!panel) return;
    panel.querySelectorAll('[data-apply-filters]').forEach(btn => {
        btn.addEventListener('click', () => onApply(new FormData(panel.querySelector('form'))));
    });
}

// Initialize on DOM ready (safe even if some elements aren't present)
document.addEventListener('DOMContentLoaded', () => {
    initResponsiveTable('.table[data-responsive="stack"]');
    bindViewToggle('[data-view-switcher]');
});
